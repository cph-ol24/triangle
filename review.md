Dette er et review af https://github.com/Sindt/Test-Triangle

## Review

- https://github.com/Sindt/Test-Triangle/blob/master/src/main/java/cphbusiness/test/sp1/triangle/Game.java#L10 
  Det vil altid være de samme værdier som bliver brugt til at teste
- Den tjekker ikke for "ugyldige" trekanter som eks. (500, 1, 1)
- https://github.com/Sindt/Test-Triangle/blob/master/src/main/java/cphbusiness/test/sp1/triangle/Triangle.java#L29 
  Den tjekker ikke hvis `this.c == this.b`
- https://github.com/Sindt/Test-Triangle/blob/master/src/main/java/cphbusiness/test/sp1/triangle/Triangle.java#L16
  Den tjekker ikke hvis `this.c == this.b` 
- https://github.com/Sindt/Test-Triangle/blob/master/src/main/java/cphbusiness/test/sp1/triangle/Triangle.java#L23
  Meget kompleks expression
- https://github.com/Sindt/Test-Triangle/blob/master/src/main/java/cphbusiness/test/sp1/triangle/Triangle.java#L5
  Fields kan være `final`, da de ikke ændre sig
- Evt. for at finde ud af hvilken type trekant en trekant er kræves der 3 forskellige kald