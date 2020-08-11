import { MorsecodePipe } from './morsecode.pipe';

describe('MorsecodePipe', () => {
  it('create an instance', () => {
    const pipe = new MorsecodePipe();
    expect(pipe).toBeTruthy();
  });
});
