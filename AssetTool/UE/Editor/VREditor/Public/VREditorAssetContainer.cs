namespace AssetTool
{
    [JsonAsset("VREditorAssetContainer")]
    public class UVREditorAssetContainer : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}