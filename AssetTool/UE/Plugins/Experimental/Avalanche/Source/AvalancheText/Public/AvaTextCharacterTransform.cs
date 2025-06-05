namespace AssetTool
{
    [JsonAsset("AvaTextCharacterTransform")]
    public class UAvaTextCharacterTransform : UText3DCharacterTransform
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}