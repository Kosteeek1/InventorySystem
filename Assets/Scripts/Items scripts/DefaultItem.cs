using UnityEngine;

namespace Items_scripts
{
    [CreateAssetMenu(fileName = "New Item", menuName = "Default Item")]
    public class DefaultItem : ItemSO
    {
        public void Awake()
        {
            type = ItemType.Default;
        }
    }
}
