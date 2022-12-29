using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum SpriteType 
{
    SINGLE,
    DIRECTIONAL
}

public class SpriteBehavior : MonoBehaviour
{
    [Header("Base Variables")]
    [SerializeField] private SpriteType _spriteType;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private bool _canLookVertically;
    [Header("Directional Varaibles")]
    [SerializeField] private Sprite[] _sprites;

    [SerializeField] private Transform _target;
    private Vector3 targetPos;
    private Vector3 targetDir;
    private int _directionIndex;

    void Update()
    {
        //If the sprite should rotate vertically when looking at the target
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

        if (_spriteType == SpriteType.DIRECTIONAL)
        {
            //Get signed angle
            targetPos = new Vector3(_target.position.x, transform.position.y, _target.position.z);
            targetDir = targetPos - transform.position;

            float angle = Vector3.SignedAngle(targetDir, transform.forward, Vector3.up);

            //Flip sprite horizontally if angle is positive
            Vector3 tempScale = Vector3.one;
            if (angle > 0)
            {
                tempScale.x *= -1f;
            }
            _spriteRenderer.transform.localScale = tempScale;

            //Get and set the index for direction 
            _directionIndex = GetIndexForDirection(angle);

            //Update sprite to match current direction index
            _spriteRenderer.sprite = _sprites[_directionIndex];
        }
    }

    private int GetIndexForDirection(float angle)
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

        return _directionIndex;
    }

    public void SetTarget(Transform target) 
    {
        _target = target;
    }
}
