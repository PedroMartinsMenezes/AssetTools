namespace AssetTool
{
    [JsonAsset("LandscapeEditorObject")]
    public class ULandscapeEditorObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}