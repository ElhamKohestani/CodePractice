

function kangaroo(x1, v1, x2, v2) {
    // Write your code here

    let loop = 0;
    let x1InitialPosition = x1;
    let x2InitialPosition = x2;

    while(loop <= 10000)
    {
        if(x1InitialPosition == x2InitialPosition)
            return 'YES';
        
        x1InitialPosition = x1InitialPosition + v1;
        x2InitialPosition = x2InitialPosition + v2;

        if(x1InitialPosition == x2InitialPosition)
            return 'YES';
        
        loop = loop + 1;
    }

    return 'NO';
}

kangaroo(0, 2, 5, 3)