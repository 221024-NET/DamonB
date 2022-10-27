using System;
using System.Collections.Generic;

namespace PokemonApp {
    class Trainer {
        private string name;
        private int age;
        private List<Pokemon> pokemon;

        public Trainer(string name, int age) {
            this.name = name;
            this.age = age;
            this.pokemon = new List<Pokemon>();
        }

        public void catchPokemon(Pokemon newPokemon) {
            this.pokemon.Add(newPokemon);
        }

        public void viewPokemon() {
            foreach(var poke in pokemon) {
                Console.WriteLine(poke.ToString());
            }
        }
    }
}