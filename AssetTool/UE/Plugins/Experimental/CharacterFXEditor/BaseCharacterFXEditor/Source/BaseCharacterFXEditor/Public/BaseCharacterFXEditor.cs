namespace AssetTool
{
    [JsonAsset("BaseCharacterFXEditor")]
    public class UBaseCharacterFXEditor : UAssetEditor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}