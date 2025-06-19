namespace AssetTool
{
    [JsonAsset("NiagaraDataInterfaceNeighborGrid3D")]
    public class UNiagaraDataInterfaceNeighborGrid3D : UNiagaraDataInterfaceGrid3D
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}