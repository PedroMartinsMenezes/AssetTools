namespace AssetTool
{
    [JsonAsset("AvaPlayableGroup")]
    public class UAvaPlayableGroup : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}