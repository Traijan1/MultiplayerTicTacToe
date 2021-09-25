﻿using System.Collections.Generic;

namespace Backend;

public class GameManager {
    public List<Game> Games { get; private set; } = new();

    public Game GetGame(string id) {
        return Games.Find(game => game.Id == id);
    }
}
