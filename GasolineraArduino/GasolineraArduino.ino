#include <ArduinoJson.h>
String data = "";
volatile float flujo;
bool isAvailable = false;
String tipoLlenado = "";
float limiteLitros = 1.0;

const int PIN_FLUJO = 7;
const int PIN_BOMBA = 6;
const int PIN_RETORNO = 51;
const int PIN_SWITCH = 49;
const int PIN_ELECTRODO_OUT = 48;
const int PIN_ELECTRODO = 50;


void setup() {
  flujo = 0;
  pinMode(PIN_BOMBA, OUTPUT);
  pinMode(PIN_SWITCH, OUTPUT);
  pinMode(PIN_ELECTRODO_OUT, OUTPUT);
  pinMode(PIN_RETORNO, INPUT);
  pinMode(PIN_ELECTRODO, INPUT);
  pinMode(PIN_FLUJO, INPUT);
  Serial.begin(9600);
}

void loop() {
 /* digitalWrite(PIN_SWITCH, HIGH);
  int currentStateSwitch = digitalRead(PIN_RETORNO);
  if (currentStateSwitch == HIGH) {
    serializar("message", "Se activa switch");
  }*/

 if (Serial.available()) {
    readSerialPort();
  }


  if (isAvailable) {
    digitalWrite(PIN_SWITCH, HIGH);

    int currentStateSwitch = digitalRead(PIN_RETORNO);
    if (currentStateSwitch == HIGH) {
      //serializar("message", "Se activa switch");
      if(tipoLlenado == "Prepago"){
        if (flujo < limiteLitros) {
        digitalWrite(PIN_BOMBA, HIGH);
        delay(5);
        int currentStateFlow = digitalRead(PIN_FLUJO);
    
        if (currentStateFlow == HIGH) {
          //serializar("message", "Se activa flujo");
            pulse();
          }
        }
        else {
          digitalWrite(PIN_BOMBA, LOW);
          isAvailable = false;
          flujo = 0;
          serializar("message", "Ha finalizado el llenado");
          //Serial.println("Ha finalizado el llenado");
        }
        
        
      }
      
    } else {
      digitalWrite(PIN_BOMBA, LOW);
    }


  }
}

void readSerialPort() {
  char input = Serial.read();
  data += input;
  char* allchar = data.c_str();
  // Serial.println(input);
  if (input == '}') {
    StaticJsonDocument<64> doc;
    deserializeJson(doc, allchar);
    String tipoLlenadoAux = doc["tipoLlenado"];
    tipoLlenado = tipoLlenadoAux;
    if(tipoLlenado == "Prepago"){
      String limiteLitrosAux = doc["litros"];
      limiteLitros = limiteLitrosAux.toFloat();
      serializar("message", String(limiteLitros));  
    } 
    isAvailable = true;
    serializar("message", "Preparado para servir");
    data = "";
  }
}

void pulse() {
  // Serial.println("Sirviendo");
  //Serial.println(flujo);
  delay(2);
  String flujoString = floatToString(flujo, 2);
  serializar("flowValue", flujoString);
  flujo += 1.0 / 850.0; //calibracion recomendada
}

void serializar(String key, String message) {
  StaticJsonDocument<8> doc;
  doc[key] = message;
  serializeJson(doc, Serial);
  Serial.println();
}

String floatToString(float value, int decimales) {
  char buffer[50];  // Define un buffer lo suficientemente grande para contener la cadena resultante

  // Convierte el double a string
  dtostrf(value, 0, decimales, buffer);

  return String(buffer);
}
