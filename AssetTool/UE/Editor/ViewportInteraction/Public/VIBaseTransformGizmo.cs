namespace AssetTool
{
    [JsonAsset("BaseTransformGizmo")]
    public class ABaseTransformGizmo : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}