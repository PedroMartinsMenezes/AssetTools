namespace AssetTool
{
    [JsonAsset("DeformableSolverComponent")]
    public class UDeformableSolverComponent : USceneComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}