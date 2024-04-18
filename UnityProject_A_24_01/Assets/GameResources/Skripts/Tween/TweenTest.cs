using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenTest: MonoBehaviour
{
    Sequence sequence;
    Tween tween;
    // Start is called before the first frame update
    void Start()
    {
        //Tween ����
        //transform.DOMoveX(5, 2);
        //transform.DORotate(new Vector3(0, 0, 180), 2);
        //transform.DOScale(new Vector3(2, 2, 2), 2);

        //��ü �ּ� �� �ּ� ���� Ctrl + K + C , Ctrl + K + U
        //Sequence Seauence = DOTween.Sequence();
        //Seauence.Append(transform.DOMoveX(5, 2));
        //Seauence.Append(transform.DORotate(new Vector3(0, 0, 180), 2));
        //Seauence.Append(transform.DOScale(new Vector3(2, 2, 2), 2));

        //transform.DOMoveX(5, 2f).SetEase(Ease. OutBounce);
        //transform.DOShakeRotation(2f, new Vector3(0, 0, 90), 10, 90);

        //transform.DOMoveX(5, 2f).SetEase(Ease.OutBounce).OnComplete(TweenEnd);  //Ʈ���� �Ϸ�Ǹ� TweenEnd�Լ��� ȣ���Ѵ�.

        sequence = DOTween.Sequence();
        sequence.Append(transform.DOMoveX(5, 1));
        sequence.SetLoops(-1, LoopType.Yoyo);

    }

    void TweenEnd()
    {
        gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sequence.Kill();
            //tween.Kill();
        }
    }
}
