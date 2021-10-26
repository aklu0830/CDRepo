class Ninja {
    constructor(name) {
        this.name = name;
        this.health = 80;
        this.speed = 3;
        this.strength = 3;
    }

    sayName = () => {
        console.log(this.name)
    }

    showStats = () => {
        console.log(this.health)
        console.log(this.speed)
        console.log(this.strength)
    }

    drinkSake = () => {
        this.health+=10;
        console.log(this.health)
    }


}

class Sensei extends Ninja{
    constructor() {
        super();
        this.health = 90;
        this.wisdom = 10;
    }

    speakWidsom = () => {
        this.drinkSake()
        console.log("What one programmer can do in one month, two programmers can do in two months.")
    }

}

const sensei = new Sensei();
sensei.speakWidsom()