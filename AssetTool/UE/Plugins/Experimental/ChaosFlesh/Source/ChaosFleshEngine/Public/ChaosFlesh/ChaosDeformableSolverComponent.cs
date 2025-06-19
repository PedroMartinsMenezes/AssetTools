namespace AssetTool
{
    [JsonAsset("DeformableSolverComponent")]
    public class UDeformableSolverComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}