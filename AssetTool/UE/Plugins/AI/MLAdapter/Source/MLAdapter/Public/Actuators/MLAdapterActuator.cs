namespace AssetTool
{
    [JsonAsset("MLAdapterActuator")]
    public class UMLAdapterActuator : UMLAdapterAgentElement
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}