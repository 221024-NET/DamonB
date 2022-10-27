using System;
using System.Collections.Generic;

namespace PokemonApp {
    class Trainer {
        private string name {get; set;}
        private int age {get; set;}
        private List<Pokemon> pokemon {get; set;}

        public Trainer(string name, int age) {
            this.name = name;
            this.age = age;
            this.pokemon = new List<Pokemon>();
        }

        public void trainerInfo() {
            Console.WriteLine("Hi! My name is " + this.name + " and I am " + this.age + " years old. I wanna be the very best...");
        }

        public void catchPokemon(Pokemon newPokemon) {
            this.pokemon.Add(newPokemon);
        }

        public void viewPokemon() {
            Console.WriteLine("Here are all of " + this.name + "'s current Pokemon(name, type):");
            foreach(var poke in pokemon) {
                Console.WriteLine(poke.ToString());
            }
        }
    }
}