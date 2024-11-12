namespace AssetTool
{
    [JsonAsset("NiagaraDataInterfaceNeighborGrid3D")]
    public class UNiagaraDataInterfaceNeighborGrid3D : UNiagaraDataInterfaceGrid3D
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}