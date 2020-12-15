import beers from '../beers.js'
import assert from 'assert'
import should from 'should'
describe('Array', function() {
  describe('beers array', function() {
    it('should have a beer called Impaled', function() {
        beers.findIndex(b => b.name == "Impaled").should.not.equal(-1);
    });
  });
});