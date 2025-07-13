namespace AssetTool
{
    [JsonAsset("LandscapeEditorObject")]
    public class ULandscapeEditorObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}