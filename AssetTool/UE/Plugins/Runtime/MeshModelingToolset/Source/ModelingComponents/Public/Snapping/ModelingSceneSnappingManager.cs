namespace AssetTool
{
    [JsonAsset("ModelingSceneSnappingManager")]
    public class UModelingSceneSnappingManager : USceneSnappingManager
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}