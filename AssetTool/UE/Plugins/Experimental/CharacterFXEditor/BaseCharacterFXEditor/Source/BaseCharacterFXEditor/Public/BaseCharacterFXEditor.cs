namespace AssetTool
{
    [JsonAsset("BaseCharacterFXEditor")]
    public class UBaseCharacterFXEditor : UAssetEditor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}