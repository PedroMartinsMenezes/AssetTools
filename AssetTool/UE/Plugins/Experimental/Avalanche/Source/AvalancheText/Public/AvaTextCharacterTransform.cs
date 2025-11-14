namespace AssetTool
{
    [JsonAsset("AvaTextCharacterTransform")]
    public class UAvaTextCharacterTransform : UText3DCharacterTransform
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}