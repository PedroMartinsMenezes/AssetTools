namespace AssetTool
{
    [JsonAsset("AvaPlayableTransition")]
    public class UAvaPlayableTransition : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}