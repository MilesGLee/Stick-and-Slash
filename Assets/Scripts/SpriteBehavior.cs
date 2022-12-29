using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteBehavior : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private bool _canLookVertically;
    private Vector3 targetPos;
    private Vector3 targetDir;

    public SpriteRenderer _spriteRenderer;
    public Sprite[] sprites;

    public float angle;
    public int lastIndex;

    void Start()
    {

    }

    void Update()
    {
        //Handle LookAt
        if (_canLookVertically)
        {
            _spriteRenderer.transform.LookAt(_target);
        }
        else
        {
            Vector3 modifiedTarget = _target.position;
            modifiedTarget.y = transform.position.y;

            _spriteRenderer.transform.LookAt(modifiedTarget);
        }

        //Get Signed Angle
        targetPos = new Vector3(_target.position.x, transform.position.y, _target.position.z);
        targetDir = targetPos - transform.position;

        angle = Vector3.SignedAngle(targetDir, transform.forward, Vector3.up);

        Vector3 tempScale = Vector3.one;
        if (angle > 0) { tempScale.x *= -1f; }
        _spriteRenderer.transform.localScale = tempScale;

        lastIndex = GetIndex(angle);

        _spriteRenderer.sprite = sprites[lastIndex];
    }

    private int GetIndex(float angle)
    {
        //front
        if (angle > -22.5f && angle < 22.6f)
            return 0;
        if (angle >= 22.5f && angle < 67.5f)
            return 7;
        if (angle >= 67.5f && angle < 112.5f)
            return 6;
        if (angle >= 112.5f && angle < 157.5f)
            return 5;

        //back
        if (angle <= -157.5f || angle >= 157.5f)
            return 4;
        if (angle >= -157.4f && angle < -112.5f)
            return 3;
        if (angle >= -112.5f && angle < -67.5f)
            return 2;
        if (angle >= -67.5f && angle <= -22.5f)
            return 1;

        return lastIndex;
    }
}
