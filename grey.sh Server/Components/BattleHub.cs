﻿namespace grey.sh_Server.Components
{
  public class BattleHub
  {
    public BattlePlayer Player1 { get; set; }
    public BattlePlayer Player2 { get; set; }

    public bool TurnEnded => Player1.TurnEnded && Player2.TurnEnded;
  }
}