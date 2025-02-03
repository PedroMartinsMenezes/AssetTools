namespace AssetTool
{
    public class FAnimNextDecoratorSharedData : ITransferible
    {
        public virtual ITransferible Move(Transfer transfer)
        {
            return this;
        }
    }
}
