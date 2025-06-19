namespace AssetTool
{
    [JsonAsset("AvaTextCharacterTransform")]
    public class UAvaTextCharacterTransform : UText3DCharacterTransform
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}