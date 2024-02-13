namespace DefaultNamespace
{
    public class GameTags 
    {
        public static GameTags Instance { get; private set; }
        public string Ostacle => "Obstacle";
        public string ItemColorChange => "Item_ColorChange";

        public GameTags()
        {
            if (Instance == null)
            {
                Instance = this;
            }
        }
    }
}