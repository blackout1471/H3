import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'morsecode'
})
export class MorsecodePipe implements PipeTransform {

  transform(value: string): string {
    let rt: string = "";
    for (var i = 0; i < value.length; i++) {
      rt += this.convertChar(value[i]);
    }

    return rt;
  }

  convertChar(value: string): string {
    let rt: string;

    switch (value) {
      case "A":
        rt = ".-";
        break;
      case "B":
        rt = "-...";
        break;
      case "C":
        rt = "-.-.";
        break;
      case "D":
        rt = "-..";
        break;
      case "E":
        rt = ".";
        break;
      case "F":
        rt = "..-.";
        break;
      case "G":
        rt = "--.";
        break;
      case "H":
        rt = "....";
        break;
      case "I":
        rt = "..";
        break;
      case "J":
        rt = ".---";
        break;
      case "K":
        rt = "-.-";
        break;
      case "L":
        rt = ".-..";
        break;
      case "N":
        rt = "-.";
        break;
      case "M":
        rt = "--";
        break;
      case "O":
        rt = "---";
        break;
      case "P":
        rt = ".--.";
        break;
      case "Q":
        rt = "--.-";
        break;
      case "R":
        rt = ".-.";
        break;
      case "S":
        rt = "...";
        break;
      case "T":
        rt = "-";
        break;
      case "U":
        rt = "..-";
        break;
      case "V":
        rt = "...-";
        break;
      case "W":
        rt = ".--";
        break;
      case "X":
        rt = "-..-";
        break;
      case "Y":
        rt = "-.--";
        break;
      case "Z":
        rt = "--..";
        break;
      case "Æ":
        rt = ".-.-";
        break;
      case "Ø":
        rt = "---.";
        break;
      case "Å":
        rt = ".--.-";
        break;
      case "1":
        rt = ".----";
        break;
      case "2":
        rt = "..--";
        break;
      case "3":
        rt = "...--";
        break;
      case "4":
        rt = "....-";
        break;
      case "5":
        rt = ".....";
        break;
      case "6":
        rt = "-....";
        break;
      case "7":
        rt = "--...";
        break;
      case "8":
        rt = "---..";
        break;
      case "9":
        rt = "----.";
        break;
      case "0":
        rt = "-----";
        break;
      case ".":
        rt = ".-.-.-";
        break;
      case ",":
        rt = "--..--";
        break;
      case ":":
        rt = "---...";
        break;
      case "?":
        rt = "..--..";
        break;
      case "'":
        rt = ".----.";
        break;
      case "-":
        rt = "-....-";
        break;
      case "/":
        rt = "-..-.";
        break;
      case "(":
        rt = "-.--.";
        break;
      case ")":
        rt = "-.--.-";
        break;
      case "\"":
        rt = ".-..-.";
        break;
      case "\n":
        rt = ".-.-";
        break;
      case "*":
        rt = "-..-";
        break;
      case "@":
        rt = ".--.-.";
        break;
      default:
        rt = "unknown";
        break;
    }

    return rt;
  }

}
