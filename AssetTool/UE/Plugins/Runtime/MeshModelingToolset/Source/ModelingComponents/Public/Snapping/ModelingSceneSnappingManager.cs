namespace AssetTool
{
    [JsonAsset("ModelingSceneSnappingManager")]
    public class UModelingSceneSnappingManager : USceneSnappingManager
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}