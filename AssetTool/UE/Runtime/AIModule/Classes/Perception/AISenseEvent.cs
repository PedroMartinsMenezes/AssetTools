namespace AssetTool
{
    [JsonAsset("AISenseEvent")]
    public class UAISenseEvent : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}