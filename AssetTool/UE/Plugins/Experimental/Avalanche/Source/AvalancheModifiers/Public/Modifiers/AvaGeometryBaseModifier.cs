namespace AssetTool
{
    [JsonAsset("AvaGeometryBaseModifier")]
    public class UAvaGeometryBaseModifier : UAvaBaseModifier
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}