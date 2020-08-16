import { Element } from 'src/app/Element';

export class PeriodicElement extends Element {
  public getGroup(): number { return this.group; }
  private setGroup(value: number) { this.group = value; }

  public getYPos(): number { return this.yPos; }
  private setYPos(value: number) { this.yPos = value; }

  private group: number;
  private yPos: number;

  constructor(ypos: number, group: number, atomicnumber: number, symbol: string, name: string, atomicweight: number, electronspershell: number) {
    super(atomicnumber, symbol, name, atomicweight, electronspershell);
    this.setGroup(group);
    this.setYPos(ypos);
  }
}
