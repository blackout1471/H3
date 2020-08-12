import { Element } from 'src/app/Element';

export class PeriodicElement extends Element {
  public getGroup(): number { return this.group; }
  private setGroup(value: number) { this.group = value; }

  private group: number;

  constructor(group: number, atomicnumber: number, symbol: string, name: string, atomicweight: number, electronspershell: number) {
    super(atomicnumber, symbol, name, atomicweight, electronspershell);
    this.setGroup(group);
  }
}
