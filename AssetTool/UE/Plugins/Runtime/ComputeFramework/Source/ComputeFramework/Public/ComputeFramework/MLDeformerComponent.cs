namespace AssetTool
{
    [JsonAsset("MLDeformerComponent")]
    public class UMLDeformerComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}