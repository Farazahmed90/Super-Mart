//
//  ViewController.swift
//  dice
//
//  Created by Faraz_Ahmed on 03/03/2019.
//  Copyright © 2019 d_tech. All rights reserved.
//

import UIKit

class ViewController: UIViewController {
    
    let dicearray = ["dice1","dice2","dice3","dice4","dice5","dice6"];
    
    var randomDiceIndex1: Int = 0;
    var randomDiceIndex2: Int = 0;
    

    @IBOutlet weak var diceImageView1: UIImageView!
    @IBOutlet weak var diceImageView2: UIImageView!
    override func viewDidLoad() {
        super.viewDidLoad()
        updateDiceImages()
        // Do any additional setup after loading the view, typically from a nib.
    }
    override func motionEnded(_ motion: UIEventSubtype, with event: UIEvent?) {
        updateDiceImages()
    }

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }

    @IBAction func rollButton(_ sender: UIButton) {
        updateDiceImages()
    }
    func updateDiceImages(){
        randomDiceIndex1 = Int(arc4random_uniform(6))
        randomDiceIndex2 = Int(arc4random_uniform(6))
        diceImageView1.image = UIImage(named: dicearray[randomDiceIndex1])
        diceImageView2.image = UIImage(named: dicearray[randomDiceIndex2])
    }

}
