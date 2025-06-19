namespace AssetTool
{
    [JsonAsset("AISenseConfig")]
    public class UAISenseConfig : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}