﻿
public class ClassFactory {

	public static GameModel CreateGameModel() {
        //return new Game2048();
        return new GameNumberReader();
    }
}
