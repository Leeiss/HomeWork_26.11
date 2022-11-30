namespace Tumakov10
{
    abstract class Figure
    {
        public enum condition
        {
            visible,
            invisible
        }
        public Figure(string color, condition condition)
        {
            Color = color;
            Condition = condition;
        }
        public string Color { get; set; }
        public condition Condition { get; set; }
        public abstract void MoveX(int x);
        public abstract void MoveY(int y);
        public abstract void ChangeColor(string color);
        public abstract void ChangeCondition(condition Condition);


    }
}

