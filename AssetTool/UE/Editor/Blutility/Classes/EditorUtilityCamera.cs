namespace AssetTool
{
    [JsonAsset("EditorUtilityCamera")]
    public class AEditorUtilityCamera : ACameraActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}