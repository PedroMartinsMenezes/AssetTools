namespace AssetTool
{
    [JsonAsset("GroomSolverComponent")]
    public class UGroomSolverComponent : UMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}