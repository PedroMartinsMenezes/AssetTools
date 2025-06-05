namespace AssetTool
{
    [JsonAsset("AvaPlayableLocalTransition")]
    public class UAvaPlayableLocalTransition : UAvaPlayableTransition
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}