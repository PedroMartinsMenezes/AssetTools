namespace AssetTool
{
    [JsonAsset("VREditorBaseUserWidget")]
    public class UVREditorBaseUserWidget : UUserWidget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}