namespace AssetTool
{
    [JsonAsset("AvaPlayableTransition")]
    public class UAvaPlayableTransition : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}