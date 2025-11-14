namespace AssetTool
{
    [JsonAsset("VREditorBaseUserWidget")]
    public class UVREditorBaseUserWidget : UUserWidget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}