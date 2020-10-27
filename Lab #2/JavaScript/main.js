function getSidesValues(AX, AY, BX, BY, CX, CY) {
    let buff = [];

    buff[0] = Math.sqrt(Math.pow(BX - AX, 2) + Math.pow((BY - AY), 2));
    buff[1] = Math.sqrt(Math.pow(CX - BX, 2) + Math.pow((CY - BY), 2));
    buff[2] = Math.sqrt(Math.pow(CX - AX, 2) + Math.pow((CY - AY), 2));

    return buff;
};


function getTriangleType (Sides){ 
    if (Sides[0] == Sides[1] && Sides[1] == Sides[2] && Sides[0] == Sides[2]) { return "Рівносторонній"; }
    else if (Sides[0] == Sides[1] || Sides[1] == Sides[2] || Sides[0] == Sides[2]) { return "Рівнобедрений"; }
    return "Різносторонній";
};

console.log("Трикутник ABC: " + getTriangleType(getSidesValues(0, 3, -2, 0, 0, -3)));