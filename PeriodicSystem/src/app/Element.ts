export class Element {

  public getAtomicNumber(): number { return this.atomicNumber; }
  public getSymbol(): string { return this.symbol; }
  public getName(): string { return this.name; }
  public getAtomicWeight(): number { return this.atomicWeight; }
  public getElectronsPerShell(): number { return this.electronsPerShell; }

  public setAtomicNumber(value:number) { this.atomicNumber = value; }
  public setSymbol(value:string) { this.symbol = value; }
  public setName(value: string) { this.name = value; }
  public setAtomicWeight(value: number) { this.atomicWeight = value; }
  public setElectronsPerShell(value: number) { this.electronsPerShell = value; }

  private atomicNumber: number;
  private symbol: string;
  private name: string;
  private atomicWeight: number;
  private electronsPerShell: number;

  constructor(atomicnumber: number, symbol: string, name: string, atomicweight: number, electronspershell: number) {
    this.setAtomicNumber(atomicnumber);
    this.setSymbol(symbol);
    this.setName(name);
    this.setAtomicWeight(atomicweight);
    this.setElectronsPerShell(electronspershell);
  }
}
