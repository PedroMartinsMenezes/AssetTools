namespace AssetTool
{
    [JsonAsset("EditorUtilityCamera")]
    public class AEditorUtilityCamera : ACameraActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}