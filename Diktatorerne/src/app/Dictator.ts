export class Dictator {

  firstName: string;
  lastName: string;
  yearOfBirth: number;
  yearOfDeath: number;
  description: string;

  constructor(firstname: string, lastname: string, yearofbirth: number, yearofdeath: number, description: string) {
    this.firstName = firstname;
    this.lastName = lastname;
    this.yearOfBirth = yearofbirth;
    this.yearOfDeath = yearofdeath;
    this.description = description;
  }
}
