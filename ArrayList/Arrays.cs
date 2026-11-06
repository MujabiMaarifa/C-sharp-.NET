using System;
using System.Collections;
using System.Collections.Generic;

public class Arrays{
    public static void Main(string[] args) {
        string[] cars = {"Volvo", "Toyota", "Mercedes", "Audi", "Lamborgini"};
        Console.WriteLine(cars[0][0]);

        for(int i=0; i<cars.Length; i++) {
            Console.WriteLine(cars[i]);
            for(int j=0; j<cars[i].Length; j++) {
                Console.WriteLine(cars[i][j]);
            }
        }

        Array.Sort(cars);
        foreach(string i in cars) {
            Console.WriteLine(i);
        }
    }
}

