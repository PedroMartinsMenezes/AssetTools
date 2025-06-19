namespace AssetTool
{
    [JsonAsset("MLDeformerComponent")]
    public class UMLDeformerComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}