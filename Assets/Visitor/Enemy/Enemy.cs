using UnityEngine;

namespace Assets.Visitor
{
    public class Enemy: MonoBehaviour
    {
        //Какая то общая логика врага: передвижение, жизни и тп.

        public void MoveTo(Vector3 position) => transform.position = position;
    }
}
