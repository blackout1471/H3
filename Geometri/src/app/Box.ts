abstract class Box {
  constructor() {}

  abstract CalculateAreal(): number;

  abstract CalculatePerimeter(): number;
}

export class Rectangle extends Box {

  x: number;
  y: number;

  constructor(side1: number, side2: number) {
    super();
    this.x = side1;
    this.y = side2;
  }

  CalculateAreal(): number {
    return this.x * this.y;
  }

  CalculatePerimeter(): number {
    return this.x + this.y;
  }
}

export class Square extends Box {
  x: number;

  constructor(side: number) {
    super();
    this.x = side;
  }

  CalculateAreal(): number {
    return this.x * this.x;
  }

  CalculatePerimeter(): number {
    return this.x * 4;
  }
}
