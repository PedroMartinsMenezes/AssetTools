namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterInstance")]
    public class UMetaHumanCharacterInstance : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}