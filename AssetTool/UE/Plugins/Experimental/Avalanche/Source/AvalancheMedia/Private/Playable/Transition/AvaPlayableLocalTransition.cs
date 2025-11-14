namespace AssetTool
{
    [JsonAsset("AvaPlayableLocalTransition")]
    public class UAvaPlayableLocalTransition : UAvaPlayableTransition
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}