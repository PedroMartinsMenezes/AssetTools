namespace AssetTool
{
    [JsonAsset("AvaPlayableLocalTransition")]
    public class UAvaPlayableLocalTransition : UAvaPlayableTransition
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}